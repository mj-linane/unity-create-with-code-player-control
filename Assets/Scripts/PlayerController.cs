using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private float carSpeed = 20.0f;


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Move the vehicle forward
    // transform.Translate(0, 0, 1);

    // Move the vehicle forward using Vector
    // transform.Translate(Vector3.forward * Time.deltaTime * 20);

    // Move the vehicle forward using a variable for speed
    transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);
  }
}