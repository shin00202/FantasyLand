using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{

    public enum MoveType{
        WAY_POINT,
        LOOK_AT,
        GEAR_VR
    }

    public MoveType moveType = MoveType.WAY_POINT;
    public float speed = 1.0f;
    public float damping = 3.0f;

    // Start is called before the first frame update
    public Transform[] points;
    private Transform tr;
    private CharacterController cc;
    private Transform camTr;
    private int nextIdx = 1;
    void Start()
    {
        tr = GetComponent<Transform>();
        cc = GetComponent<CharacterController>();
        camTr = Camera.main.GetComponent<Transform>();
        GameObject wayPointGroup = GameObject.Find("WayPointGroup");
        if (wayPointGroup != null)
        {
            points = wayPointGroup.GetComponentsInChildren<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (moveType) 
        {
            case MoveType.WAY_POINT:
                MoveWayPoint();
                break;
            case MoveType.LOOK_AT:
                MoveLookAt(1);
                break;
            case MoveType.GEAR_VR:
                break;
        }
        
    }

    void MoveWayPoint()
    {
        Vector3 direction = poin
    }
}
