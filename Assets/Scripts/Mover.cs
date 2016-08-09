using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    private Rigidbody rb;

    [SerializeField]
    private float speed;

	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
	}
}
