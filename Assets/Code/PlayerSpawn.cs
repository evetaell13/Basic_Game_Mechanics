using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{


    public Player Player;

    private Player _newPlayer;

    void Start()
    {
        _newPlayer =  Instantiate(Player, new Vector3(3, 0, 0),  Quaternion.identity);

    }

    void Update()
    {
        if (_newPlayer.IsEnemy)
        {
            _newPlayer.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (_newPlayer.IsAlly)
        {
            _newPlayer.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }

    
}