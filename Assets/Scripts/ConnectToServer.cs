using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loading...");
        // Connect to the Photon server
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        // Once connected to Photon, load the Main Menu Scene
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
