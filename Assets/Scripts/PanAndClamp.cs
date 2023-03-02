using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanAndClamp : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x *speed * Time.deltaTime , -TouchDeltaPosition.y *speed * Time.deltaTime, 0f);

            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, -5f, 5f),
                Mathf.Clamp(transform.position.y, -5f, 5f),
                -10f
            );

        }
    }
}
