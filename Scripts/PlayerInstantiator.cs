using UnityEngine;
using System.Collections;

public class PlayerInstantiator : MonoBehaviour 
{
    public GameObject playerModel;
    public Vector3 instantationCoordinates;

	// Use this for initialization
	void Start () 
    {
        Instantiate(playerModel, instantationCoordinates, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
