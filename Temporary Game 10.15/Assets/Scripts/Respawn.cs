using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //Put this script onto whatever collider should kill the player.
    
    [SerializeField]
    private Transform Player; //When you apply this script, designate the "Player" to what the player character is.
    [SerializeField]
    private Transform respawnPoint; //Make an invisible/"empty" object and put it where you want the player to respawn.
    //Then assign that object to "respawn point" when they ask.



    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }//Establised player and respawn point. Made it so when triggered player position will become whatever the respawn is designated as.
     //Script given to me by Davon.
}
