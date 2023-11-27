using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject prefabProjectile;

    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }
    private void OnMouseEnter()
    {
        //print("Slingshot: onMouseEnter");
        launchPoint.SetActive(true);

    }

    private void OnMouseExit()
    {
        //print("Slingshot: onMouseExit");
        launchPoint.SetActive(false);

    }

    private void OnMouseDown() 
    {
        aimingMode = true;
        projectile = Instantiate(prefabProjectile);
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }
}
