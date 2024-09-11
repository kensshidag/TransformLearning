using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStaight : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
