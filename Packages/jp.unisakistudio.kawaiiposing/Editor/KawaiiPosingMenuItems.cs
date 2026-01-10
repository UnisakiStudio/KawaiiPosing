/*
 * KawaiiPosingEditor
 * 可愛いポーズツールの簡易設定用ツール
 * 
 * Copyright(c) 2024 UniSakiStudio
 * Released under the MIT license
 * https://opensource.org/licenses/mit-license.php
 */

using UnityEditor;
using UnityEngine;
using VRC.SDK3.Avatars.Components;
using jp.unisakistudio.posingsystemeditor;
using System.IO;

#if UNITY_EDITOR_WIN
using Microsoft.Win32;
#endif

namespace jp.unisakistudio.kawaiiposingeditor
{
    public static class KawaiiPosingMenuItems
    {
        private const string REGKEY = @"SOFTWARE\UnisakiStudio";
        private const string KAWAIIPOSING_APPKEY = "kawaiiposing";
        private const string LICENSE_VALUE = "licensed";

        [MenuItem("GameObject/ゆにさきスタジオ/可愛いポーズツール追加", false, 20)]
        static public void AddPrefab01() { PosingSystemMenuItems.AddPrefab("可愛いポーズ"); }
        [MenuItem("GameObject/ゆにさきスタジオ/可愛いポーズツール追加(8bit・足の高さなし)", false, 21)]
        static public void AddPrefab10() { PosingSystemMenuItems.AddPrefab("可愛いポーズ(8bit・足の高さなし)"); }
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/可愛い座り(男)ツール追加", false, 30)]
        static public void AddPrefab02() { PosingSystemMenuItems.AddPrefab("可愛い座り[男]"); }
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/可愛い座り(女)ツール追加", false, 31)]
        static public void AddPrefab03() { PosingSystemMenuItems.AddPrefab("可愛い座り[女]"); }
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/添い寝ツール追加", false, 34)]
        static public void AddPrefab06() { PosingSystemMenuItems.AddPrefab("添い寝"); }
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/ごろ寝システムEX追加", false, 35)]
        static public void AddPrefab07() { PosingSystemMenuItems.AddPrefab("ごろ寝システムEX"); }
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/VRC想定移動モーション(無料配布)追加", false, 36)]
        static public void AddPrefab08() { PosingSystemMenuItems.AddPrefab("VRC想定移動モーション（無料配布）"); }
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/少女モーション集追加", false, 37)]
        static public void AddPrefab09() { PosingSystemMenuItems.AddPrefab("少女モーション集"); }

        [MenuItem("GameObject/ゆにさきスタジオ/可愛いポーズツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/可愛いポーズツール追加(8bit・足の高さなし)", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/可愛い座り(男)ツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/可愛い座り(女)ツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/三点だいしゅき(男)ツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/三点だいしゅき(女)ツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/添い寝ツール追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/ごろ寝システムEX追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/VRC想定移動モーション(無料配布)追加", true)]
        [MenuItem("GameObject/ゆにさきスタジオ/他商品連携用Prefabs/少女モーション集追加", true)]
        private static bool Validate()
        {
            if (!Selection.activeGameObject)
            {
                return false;
            }
            var avatar = Selection.activeGameObject.GetComponent<VRCAvatarDescriptor>();
            return avatar != null;
        }
        
        // ========================================
        // ライセンス関連
        // ========================================
        
        /// <summary>
        /// Mac/Linux用の設定ファイルパス
        /// </summary>
        private static string GetLicenseFilePath()
        {
#if UNITY_EDITOR_OSX
            string appSupport = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appSupport, "UnisakiStudio", $"{KAWAIIPOSING_APPKEY}.lic");
#elif UNITY_EDITOR_LINUX
            string homeDir = System.Environment.GetEnvironmentVariable("HOME");
            return Path.Combine(homeDir, ".local", "share", "UnisakiStudio", $"{KAWAIIPOSING_APPKEY}.lic");
#else
            return null;
#endif
        }
        
        /// <summary>
        /// ライセンスがインストールされているかチェック
        /// </summary>
        private static bool IsLicensed()
        {
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.OpenSubKey(REGKEY);
                if (regKey != null)
                {
                    var value = (string)regKey.GetValue(KAWAIIPOSING_APPKEY);
                    regKey.Close();
                    return value == LICENSE_VALUE;
                }
            }
            catch (System.Exception)
            {
                // 例外は無視
            }
            return false;
#elif UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath();
                if (File.Exists(licenseFilePath))
                {
                    string fileContent = File.ReadAllText(licenseFilePath);
                    return fileContent == LICENSE_VALUE;
                }
            }
            catch (System.Exception)
            {
                // 例外は無視
            }
            return false;
#else
            return false;
#endif
        }
        
        /// <summary>
        /// ライセンスを削除
        /// </summary>
        [MenuItem("Tools/ゆにさきスタジオ/可愛いポーズツールライセンス削除", false, 200)]
        public static void UninstallLicense()
        {
            if (!IsLicensed())
            {
                EditorUtility.DisplayDialog(
                    "ライセンスの削除",
                    "可愛いポーズツールのライセンスはインストールされていません。",
                    "OK"
                );
                return;
            }
            
            bool shouldUninstall = EditorUtility.DisplayDialog(
                "ライセンス削除",
                "可愛いポーズツールのライセンスを削除しますか？\n\n" +
                "削除すると、ツールの機能が制限されます。\n" +
                "再度ライセンスを有効化するには、ライセンスインストーラーを再インポートする必要があります。",
                "削除",
                "キャンセル"
            );
            
            if (!shouldUninstall)
            {
                return;
            }
            
            string resultMessage = "";
            
#if UNITY_EDITOR_WIN
            try
            {
                var regKey = Registry.CurrentUser.OpenSubKey(REGKEY, true);
                if (regKey != null)
                {
                    // KawaiiPosingライセンスを削除
                    try
                    {
                        regKey.DeleteValue(KAWAIIPOSING_APPKEY, false);
                    }
                    catch (System.Exception) { }
                    
                    // レジストリキーが空になった場合は削除
                    if (regKey.ValueCount == 0 && regKey.SubKeyCount == 0)
                    {
                        regKey.Close();
                        Registry.CurrentUser.DeleteSubKey(REGKEY, false);
                        resultMessage = "可愛いポーズツールのライセンスを削除しました。";
                    }
                    else
                    {
                        regKey.Close();
                        resultMessage = "可愛いポーズツールのライセンスを削除しました。\n（他のゆにさきスタジオ商品のライセンスは保持されます）";
                    }
                    
                    Debug.Log($"[KawaiiPosing] {resultMessage}");
                }
                else
                {
                    resultMessage = "ライセンス情報は見つかりませんでした。";
                }
            }
            catch (System.Exception ex)
            {
                resultMessage = $"ライセンスの削除に失敗しました: {ex.Message}";
                Debug.LogError($"[KawaiiPosing] {resultMessage}");
            }
#endif
            
#if UNITY_EDITOR_OSX || UNITY_EDITOR_LINUX
            try
            {
                string licenseFilePath = GetLicenseFilePath();
                
                // ライセンスファイルを削除
                if (File.Exists(licenseFilePath))
                {
                    File.Delete(licenseFilePath);
                    
                    // ディレクトリが空になった場合は削除
                    string directoryPath = Path.GetDirectoryName(licenseFilePath);
                    if (Directory.Exists(directoryPath) && 
                        Directory.GetFiles(directoryPath).Length == 0 && 
                        Directory.GetDirectories(directoryPath).Length == 0)
                    {
                        Directory.Delete(directoryPath);
                        resultMessage = "可愛いポーズツールのライセンスを削除しました。";
                    }
                    else
                    {
                        resultMessage = "可愛いポーズツールのライセンスを削除しました。\n（他のゆにさきスタジオ商品のライセンスは保持されます）";
                    }
                    
                    Debug.Log($"[KawaiiPosing] {resultMessage}");
                }
                else
                {
                    resultMessage = "ライセンス情報は見つかりませんでした。";
                }
            }
            catch (System.Exception ex)
            {
                resultMessage = $"ライセンスの削除に失敗しました: {ex.Message}";
                Debug.LogError($"[KawaiiPosing] {resultMessage}");
            }
#endif
            
            EditorUtility.DisplayDialog(
                "ライセンス削除",
                resultMessage,
                "OK"
            );
        }
    }
}
