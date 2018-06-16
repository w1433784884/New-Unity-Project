using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    const float LENGTH = -10.0f;
    GameObject _Player;

    // Use this for initialization
    void Start()
    {
        _Player = GameObject.FindGameObjectWithTag("Player");
        transform.position = new Vector3(_Player.transform.position.x, _Player.transform.position.y, LENGTH);
        transform.LookAt(_Player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_Player.transform.position.x, _Player.transform.position.y, LENGTH);
        transform.LookAt(_Player.transform.position);
    }
}
