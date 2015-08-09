using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed; 
	public float verticalLimitUp;
	public float verticalLimitDown;
	public float horizontalLimit;
	public bool dead; 
	public Vector3 currentPosition;

	// Use this for initialization
	void Start () {
		speed = 5f;
		verticalLimitUp = 5.7f;
		verticalLimitDown = -3.4f;
		horizontalLimit = 8.5f;
		dead = true;
		currentPosition = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = currentPosition;
		if(Input.GetKey("right")){
				currentPosition.x += Time.deltaTime * speed;
		}

		if(Input.GetKey("left")){
				currentPosition.x -= Time.deltaTime * speed;
		}

		if(Input.GetKey("up")){
				currentPosition.y += Time.deltaTime * speed;
		}

		if(Input.GetKey("down")){
				currentPosition.y -= Time.deltaTime * speed;
		}
	}

	/*bool checkBounds() {
			bool firstCheck = false;
			bool secondCheck = false;
			if((currentPosition.x <= horizontalLimit) && (currentPosition.x >= -horizontalLimit)){
				firstCheck = true;
			}
			if((currentPosition.y <= verticalLimitUp) && (currentPosition.y >= verticalLimitDown)){
				secondCheck = true;
			}
			if(firstCheck && secondCheck){
				return true;
			}
			else 
				return false;
		}*/
}
