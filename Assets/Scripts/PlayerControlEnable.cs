using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class PlayerControlEnable : NetworkBehaviour
{
    void Start()
    {
        if (!isLocalPlayer)
        {
            GetComponent<PlayerController>().enabled = false;
        }

    }
}
