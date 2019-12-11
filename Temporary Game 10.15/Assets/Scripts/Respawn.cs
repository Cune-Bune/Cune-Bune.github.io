using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField]
    private Transform Player;
    [SerializeField]
    private Transform respawnPoint;



    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }//Establised player and respawn point. Made it so when triggered player position will become whatever the respawn is designated as.
     //Script given to me by Davon.
}