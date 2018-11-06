using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float minX = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosition = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosition, minX, maxX); //move position and clamp it to the bounds of the screen
        transform.position = paddlePos;
	}
}
