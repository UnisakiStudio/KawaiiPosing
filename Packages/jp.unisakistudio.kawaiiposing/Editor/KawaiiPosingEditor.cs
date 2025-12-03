using UnityEngine;
using UnityEditor;
using Microsoft.Win32;
using jp.unisakistudio.kawaiiposing;
using System.Collections.Generic;

namespace jp.unisakistudio.kawaiiposingeditor
{

    [CustomEditor(typeof(KawaiiPosing))]
    public class KawaiiPosingEditor : posingsystemeditor.PosingSystemEditor
    {
        const string REGKEY = @"SOFTWARE\UnisakiStudio";
        const string APPKEY = "kawaiiposing";
        private bool isKawaiiPosingLicensed = false;

        static KawaiiPosingEditor()
        {
            checkFunctions.Add(CheckExistFolderKawaiiPosing);
        }

        public override void OnInspectorGUI()
        {
            KawaiiPosing kawaiiPosing = target as KawaiiPosing;

            /*
             * このコメント分を含むここから先の処理は可愛いポーズツールをゆにさきスタジオから購入した場合に変更することを許可します。
             * つまり購入者はライセンスにまつわるこの先のソースコードを削除して再配布を行うことができます。
             * 逆に、購入をせずにGithubなどからソースコードを取得しただけの場合、このライセンスに関するソースコードに手を加えることは許可しません。
             */
            if (isKawaiiPosingLicensed)
            {
                base.OnInspectorGUI();
                return;
            }

            var regKey = Registry.CurrentUser.CreateSubKey(REGKEY);
            var regValue = (string)regKey.GetValue(APPKEY);

            if (regValue == "licensed")
            {
                isKawaiiPosingLicensed = true;
                base.OnInspectorGUI();
                return;
            }
            /*
             * ライセンス処理ここまで
             */

            EditorGUILayout.LabelField("可愛いポーズツール", new GUIStyle() { fontStyle = FontStyle.Bold, fontSize = 20, }, GUILayout.Height(30));

            EditorGUILayout.HelpBox("このコンピュータには可愛いポーズツールの使用が許諾されていません。Boothのショップから可愛いポーズツールを購入して、コンピュータにライセンスをインストールしてください", MessageType.Error);
            if (EditorGUILayout.LinkButton("可愛いポーズツール(Booth)"))
            {
                Application.OpenURL("https://yunisaki.booth.pm/items/5479202");
            }

        }

        private static readonly List<string> folderDefines = new()
        {
            "Assets/UnisakiStudio/KawaiiPosing",
        };

        static public List<string> CheckExistFolderKawaiiPosing()
        {
            List<string> existFolders = new();
            foreach (var folderDefine in folderDefines)
            {
                if (AssetDatabase.IsValidFolder(folderDefine))
                {
                    existFolders.Add(folderDefine);
                }
            }
            return existFolders;
        }

    }
}
