using BepInEx;
using BepInEx.Configuration;
using System.Collections;
using UnityEngine;


namespace LordAshes
{
    [BepInPlugin(Guid, Name, Version)]
    public partial class RemoteControlPlugin : BaseUnityPlugin
    {
        // Plugin info
        public const string Name = "Remote Control Plug-In";
        public const string Guid = "org.lordashes.plugins.remotecontrol";
        public const string Version = "1.0.0.0";

        // Configuration

        /// <summary>
        /// Function for initializing plugin
        /// This function is called once by TaleSpire
        /// </summary>
        void Awake()
        {
            // Not required but good idea to log this state for troubleshooting purpose
            UnityEngine.Debug.Log("Remote Control Plugin: Active.");

            StartCoroutine("RemoteControlServer");

            Utility.PostOnMainPage(this.GetType());
        }

        /// <summary>
        /// Function for determining if view mode has been toggled and, if so, activating or deactivating Character View mode.
        /// This function is called periodically by TaleSpire.
        /// </summary>
        void Update()
        {
            // Can be used to determine if a board is loaded
            // Beware: Board loaded does not necessarily mean all the minis have properly loaded and are accessible
            if (Utility.isBoardLoaded())
            {
                /*
                if (Utility.StrictKeyCheck(triggerKey.Value))
                {

                }
                */
            }
        }

        IEnumerator RemoteControlServer()
        {
            yield return new WaitForSeconds(0.1f);
            AsynchronousSocketListener.StartListening(Config.Bind("Setting","Server Port", 11000).Value);
        }
    }
}
