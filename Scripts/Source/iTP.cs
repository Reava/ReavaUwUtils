using UnityEngine;
using VRC.SDKBase;

namespace UdonSharp.Examples.Utilities
{
    public class _ITP : UdonSharpBehaviour
    {
        public Transform targetLocation;

        public override void Interact()
        {
            Networking.LocalPlayer.TeleportTo(targetLocation.position, targetLocation.rotation);
        }
    }
}