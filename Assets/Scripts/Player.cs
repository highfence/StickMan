using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bow;
    public GameObject idleArrow;
    public GameObject fireArrow;
    public GameObject freezeArrow;
    public Transform spine;
    public Transform chest;
    public AudioSource bowPullAudio;
    public AudioSource bowShootAudio;
    public Animator animator;
    public GameObject testCube;

    private Upgrades _upgrades;
    private DataContainer _container;

    private void Start()
    {
        _container = DataContainer.GetInstance();

        _upgrades = _container._upgrades;
    }

    private void Update()
    {
        ClickCheck();
    }

    private void ClickCheck()
    {
        if (Input.GetMouseButton(0))
        {
            var hitPlane = new Plane(transform.position, Vector3.up);

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            float distance;

            if (hitPlane.Raycast(ray, out distance))
            {
                var hitPoint = ray.GetPoint(distance);

                hitPoint.z = this.transform.position.z;

                testCube.transform.position = hitPoint;
            }
        }
    }
}
