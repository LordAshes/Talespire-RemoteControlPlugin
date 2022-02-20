using BepInEx;
using System.Net.Sockets;

using System.Collections;
using UnityEngine;
using static RootTargetCameraMode;

namespace LordAshes
{
    [BepInPlugin(Guid, Name, Version)]
    public partial class RemoteControlPlugin : BaseUnityPlugin
    {
        // Plugin info
        public const string Name = "Remote Control Plug-In";
        public const string Guid = "org.lordashes.plugins.remotecontrol";
        public const string Version = "1.1.0.0";

        // Configuration

        void Awake()
        {
            UnityEngine.Debug.Log("Remote Control Plugin: Active.");

            StartCoroutine("RemoteControlServer");

            Utility.PostOnMainPage(this.GetType());
        }

        IEnumerator RemoteControlServer()
        {
            yield return new WaitForSeconds(0.1f);
            AsynchronousSocketListener.StartListening(Config.Bind("Setting","Server Port", 11000).Value, MessageHandler);
        }

        private static void MessageHandler(Socket sender, string content)
        {
            content = content.Replace("\r\n", "\n");
            content = content.Replace("\r", "\n");
            content = content.Substring(0, content.IndexOf("\n"));
            Debug.Log("Remote Control Plugin: Request = " + content);

            string[] command = content.Split(',');
            CreatureBoardAsset asset = null;
            foreach (CreatureBoardAsset check in CreaturePresenter.AllCreatureAssets)
            {
                if ((check.Creature.Name + "<>").Substring(0, (check.Creature.Name + "<>").IndexOf("<")) == command[0]) { asset = check; break; }
            }
            float amount = 1.0f;
            if (command.Length > 2) { float.TryParse(command[2], out amount); }
            if (asset != null)
            {
                switch (command[1].ToUpper())
                {
                    case "DELETE":
                        asset.RequestDelete();
                        break;
                    case "UP":
                        asset.MoveTo(new Vector3(asset.transform.position.x, asset.transform.position.y + amount, asset.transform.position.z));
                        break;
                    case "DOWN":
                        asset.MoveTo(new Vector3(asset.transform.position.x, asset.transform.position.y - amount, asset.transform.position.z));
                        break;
                    case "FORWARD":
                    case "FORWARDANDFACE":
                        asset.MoveTo(new Vector3(asset.transform.position.x, asset.transform.position.y, asset.transform.position.z + amount));
                        if (command[1].ToUpper().EndsWith("ANDFACE")) { asset.CreatureRoot.transform.eulerAngles = new Vector3(asset.CreatureRoot.transform.eulerAngles.x, 180, asset.CreatureRoot.transform.eulerAngles.z); }
                        break;
                    case "BACKWARD":
                    case "BACKWARDANDFACE":
                        asset.MoveTo(new Vector3(asset.transform.position.x, asset.transform.position.y, asset.transform.position.z - amount));
                        if (command[1].ToUpper().EndsWith("ANDFACE")) { asset.CreatureRoot.transform.eulerAngles = new Vector3(asset.CreatureRoot.transform.eulerAngles.x, 0, asset.CreatureRoot.transform.eulerAngles.z); }
                        break;
                    case "LEFT":
                    case "LEFTANDFACE":
                        asset.MoveTo(new Vector3(asset.transform.position.x - amount, asset.transform.position.y, asset.transform.position.z));
                        if (command[1].ToUpper().EndsWith("ANDFACE")) { asset.CreatureRoot.transform.eulerAngles = new Vector3(asset.CreatureRoot.transform.eulerAngles.x, 90, asset.CreatureRoot.transform.eulerAngles.z); }
                        break;
                    case "RIGHT":
                    case "RIGHTANDFACE":
                        asset.MoveTo(new Vector3(asset.transform.position.x + amount, asset.transform.position.y, asset.transform.position.z));
                        if (command[1].ToUpper().EndsWith("ANDFACE")) { asset.CreatureRoot.transform.eulerAngles = new Vector3(asset.CreatureRoot.transform.eulerAngles.x, 270, asset.CreatureRoot.transform.eulerAngles.z); }
                        break;
                    case "ROTATE":
                        if (command.Length > 3) { float.TryParse(command[3], out amount); }
                        switch (command[2].ToUpper())
                        {
                            case "LEFT":
                                asset.CreatureRoot.transform.eulerAngles = new Vector3(asset.CreatureRoot.transform.eulerAngles.x, asset.CreatureRoot.transform.eulerAngles.y, asset.CreatureRoot.transform.eulerAngles.z - amount);
                                break;
                            case "RIGHT":
                                asset.CreatureRoot.transform.eulerAngles = (new Vector3(asset.CreatureRoot.transform.eulerAngles.x, asset.CreatureRoot.transform.eulerAngles.y, asset.CreatureRoot.transform.eulerAngles.z + amount));
                                break;
                            case "FORWARD":
                                asset.CreatureRoot.transform.eulerAngles = ( new Vector3(asset.CreatureRoot.transform.eulerAngles.x - amount, asset.CreatureRoot.transform.eulerAngles.y, asset.CreatureRoot.transform.eulerAngles.z));
                                break;
                            case "BACKWARD":
                                asset.CreatureRoot.transform.eulerAngles = (new Vector3(asset.CreatureRoot.transform.eulerAngles.x + amount, asset.CreatureRoot.transform.eulerAngles.y, asset.CreatureRoot.transform.eulerAngles.z));
                                break;
                            case "COUNTERCLOCKWISE":
                                asset.CreatureRoot.transform.eulerAngles = (new Vector3(asset.CreatureRoot.transform.eulerAngles.x, asset.CreatureRoot.transform.eulerAngles.y + amount, asset.CreatureRoot.transform.eulerAngles.z));
                                break;
                            case "CLOCKWISE":
                                asset.CreatureRoot.transform.eulerAngles = (new Vector3(asset.CreatureRoot.transform.eulerAngles.x, asset.CreatureRoot.transform.eulerAngles.y - amount, asset.CreatureRoot.transform.eulerAngles.z));
                                break;
                        }
                        break;
                }
            }
            else if(command[0].ToUpper()=="CAMERA")
            {
                LegacyCutsceneSetup lcs = CameraController.CutsceneSetup;
                CutsceneData state = lcs.GetCutsceneState();
                switch (command[1].ToUpper())
                {
                    case "UP":
                        state.Position = new Vector3(state.Position.x, state.Position.y + amount, state.Position.z);
                        break;
                    case "DOWN":
                        state.Position = new Vector3(state.Position.x, state.Position.y - amount, state.Position.z);
                        break;
                    case "FORWARD":
                        state.Position = new Vector3(state.Position.x, state.Position.y, state.Position.z + amount);
                        break;
                    case "BACKWARD":
                        state.Position = new Vector3(state.Position.x, state.Position.y, state.Position.z - amount);
                        break;
                    case "LEFT":
                        state.Position = new Vector3(state.Position.x - amount, state.Position.y, state.Position.z);
                        break;
                    case "RIGHT":
                        state.Position = new Vector3(state.Position.x + amount, state.Position.y, state.Position.z);
                        break;
                    case "ROTATE":
                        if (command.Length > 3) { float.TryParse(command[3], out amount); }
                        switch (command[2].ToUpper())
                        {
                            case "FORWARD":
                                state.TiltEuler = state.TiltEuler - amount;
                                break;
                            case "BACKWARD":
                                state.TiltEuler = state.TiltEuler + amount;
                                break;
                            case "LEFT":
                            case "COUNTERCLOCKWISE":
                                state.RotationEuler = state.RotationEuler - amount;
                                break;
                            case "RIGHT":
                            case "CLOCKWISE":
                                state.RotationEuler = state.RotationEuler + amount;
                                break;
                        }
                        break;
                }
                lcs.PreviewCutsceneState(state);
            }
            else
            {
                Debug.Log("Remote Control Plugin: Asset Named '" + command[0] + "' Not Found.");
            }
        }
    }
}
