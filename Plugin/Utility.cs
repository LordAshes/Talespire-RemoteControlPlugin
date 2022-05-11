using BepInEx;
using BepInEx.Configuration;
using System;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LordAshes
{
    public partial class RemoteControlPlugin : BaseUnityPlugin
    {
        public static class Utility
        {
            public static void PostOnMainPage(System.Reflection.MemberInfo plugin)
            {
                SceneManager.sceneLoaded += (scene, mode) =>
                {
                    try
                    {
                        if (scene.name == "UI")
                        {
                            TextMeshProUGUI betaText = GetUITextByName("BETA");
                            if (betaText)
                            {
                                betaText.text = "INJECTED BUILD - unstable mods";
                            }
                        }
                        else
                        {
                            TextMeshProUGUI modListText = GetUITextByName("TextMeshPro Text");
                            if (modListText)
                            {
                                BepInPlugin bepInPlugin = (BepInPlugin)Attribute.GetCustomAttribute(plugin, typeof(BepInPlugin));
                                if (modListText.text.EndsWith("</size>"))
                                {
                                    modListText.text += "\n\nMods Currently Installed:\n";
                                }
                                modListText.text += "\nLord Ashes' " + bepInPlugin.Name + " - " + bepInPlugin.Version;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Log(ex);
                    }
                };
            }

            /// <summary>
            /// Function to check if the board is loaded
            /// </summary>
            /// <returns></returns>
            public static bool isBoardLoaded()
            {
                return CameraController.HasInstance && BoardSessionManager.HasInstance && !BoardSessionManager.IsLoading;
            }

            /// <summary>
            /// Method to properly evaluate shortcut keys. 
            /// </summary>
            /// <param name="check"></param>
            /// <returns></returns>
            public static bool StrictKeyCheck(KeyboardShortcut check)
            {
                if (!check.IsUp()) { return false; }
                foreach (KeyCode modifier in new KeyCode[] { KeyCode.LeftAlt, KeyCode.RightAlt, KeyCode.LeftControl, KeyCode.RightControl, KeyCode.LeftShift, KeyCode.RightShift })
                {
                    if (Input.GetKey(modifier) != check.Modifiers.Contains(modifier)) { return false; }
                }
                return true;
            }

            private static TextMeshProUGUI GetUITextByName(string name)
            {
                TextMeshProUGUI[] texts = UnityEngine.Object.FindObjectsOfType<TextMeshProUGUI>();
                for (int i = 0; i < texts.Length; i++)
                {
                    if (texts[i].name == name)
                    {
                        return texts[i];
                    }
                }
                return null;
            }

            /// <summary>
            /// Method to obtain the Base Loader Game Object based on a CreatureGuid
            /// </summary>
            /// <param name="cid">Creature Guid</param>
            /// <returns>BaseLoader Game Object</returns>
            public static GameObject GetRootLoader(CreatureGuid cid)
            {
                CreatureBoardAsset asset = null;
                CreaturePresenter.TryGetAsset(cid, out asset);
                if (asset != null)
                {
                    Type cba = typeof(CreatureBoardAsset);
                    foreach (FieldInfo fi in cba.GetRuntimeFields())
                    {
                        if (fi.Name == "_creatureRoot")
                        {
                            Transform obj = (Transform)fi.GetValue(asset);
                            return obj.gameObject;
                        }
                    }
                }
                return null;
            }

            /// <summary>
            /// Method to obtain the Base Loader Game Object based on a CreatureGuid
            /// </summary>
            /// <param name="cid">Creature Guid</param>
            /// <returns>BaseLoader Game Object</returns>
            public static GameObject GetBaseLoader(CreatureGuid cid)
            {
                CreatureBoardAsset asset = null;
                CreaturePresenter.TryGetAsset(cid, out asset);
                if (asset != null)
                {
                    Type cba = typeof(CreatureBoardAsset);
                    foreach (FieldInfo fi in cba.GetRuntimeFields())
                    {
                        if (fi.Name == "_base")
                        {
                            CreatureBase obj = (CreatureBase)fi.GetValue(asset);
                            return obj.transform.GetChild(0).gameObject;
                        }
                    }
                }
                return null;
            }

            /// <summary>
            /// Method to obtain the Asset Loader Game Object based on a CreatureGuid
            /// </summary>
            /// <param name="cid">Creature Guid</param>
            /// <returns>AssetLoader Game Object</returns>
            public static GameObject GetAssetLoader(CreatureGuid cid)
            {
                CreatureBoardAsset asset = null;
                CreaturePresenter.TryGetAsset(cid, out asset);
                if (asset != null)
                {
                    Type cba = typeof(CreatureBoardAsset);
                    foreach (FieldInfo fi in cba.GetRuntimeFields())
                    {
                        if (fi.Name == "_creatureRoot")
                        {
                            Transform obj = (Transform)fi.GetValue(asset);
                            return obj.GetChild(0).GetChild(2).GetChild(0).gameObject;
                        }
                    }
                }
                return null;
            }
        }
    }
}
