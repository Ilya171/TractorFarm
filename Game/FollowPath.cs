using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
   public enum MovementType
    {
        Moveing,
        Lerping
    }
    public MovementType Type = MovementType.Moveing;
    public MovementPath MyPath;
    public float speed = 1;
    public float maxDistance = .1f;

    private IEnumerator<Transform> poinInPath;


    private void Start()
    {
       
        if(MyPath==null)
        {
            Debug.Log("Enter way");
            return;
        }
        poinInPath = MyPath.GetNextPathPoint();
        poinInPath.MoveNext();
        if(poinInPath.Current==null)
        {
            Debug.Log("needs point");
            return;
        }
        transform.position = poinInPath.Current.position;
    }

    private void Update()
    {
        if (!GameSettings.GameOver)
        {
            transform.LookAt(poinInPath.Current.position);

             if (poinInPath == null || poinInPath.Current == null)
             {
                return;
             }
             if (Type == MovementType.Moveing)
             {
                transform.position = Vector3.MoveTowards(transform.position, poinInPath.Current.position, Time.deltaTime * speed);
             }
             else if (Type == MovementType.Lerping)
             {
                transform.position = Vector3.Lerp(transform.position, poinInPath.Current.position, Time.deltaTime * speed);
             }

             var distanceSqure = (transform.position - poinInPath.Current.position).sqrMagnitude;
             if (distanceSqure < maxDistance * maxDistance)
             {
                poinInPath.MoveNext();
             }
        }
    }
}
