/*
 * KawaiiPosingEditor
 * 可愛いポーズツールの簡易設定用ツール
 * 
 * Copyright(c) 2024 UniSakiStudio
 * Released under the MIT license
 * https://opensource.org/licenses/mit-license.php
 */

using UnityEditor;
using VRC.SDK3.Avatars.Components;
using jp.unisakistudio.posingsystemeditor;

namespace jp.unisakistudio.kawaiiposingeditor
{
    public static class KawaiiPosingMenuItems
    {
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
    }
}
