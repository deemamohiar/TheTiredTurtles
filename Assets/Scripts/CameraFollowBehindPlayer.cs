 using UnityEngine;
 using System.Collections;
 
 public class CameraFollowBehindPlayer : MonoBehaviour
 {
     [SerializeField]
     private Transform player;
 
     [SerializeField]
     private Vector3 cameraoffsetPosition = new Vector3(0, 1.8f, 1);
     [SerializeField]
     private Space cameraoffsetPositionSpace = Space.Self;
 
     [SerializeField]
     private bool lookAt = false;
 
     private void Update()
     {
         Refresh();
     }
 
     public void Refresh()
     {
         // compute position
         if(cameraoffsetPositionSpace == Space.Self)
         {
             // gets position of player
             transform.position = player.TransformPoint(cameraoffsetPosition);
         }
         else
         {
             transform.position = player.position + cameraoffsetPosition;
         }
 
         // compute rotation
         if(lookAt)
         {
            transform.LookAt(player);
         }
         // set angle of camera as the player's rotation angle
         else
         {
             transform.rotation = player.rotation;
         }
     }
 }