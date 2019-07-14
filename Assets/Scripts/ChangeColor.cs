using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

  [SerializeField] private Camera camera_;
  [SerializeField] private float distance;
  Vector3 center;
  Ray ray;
  RaycastHit hitInfo;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Shot();
    }


    center = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    ray = camera_.ScreenPointToRay(center);
    if (Physics.Raycast(ray, out hitInfo, distance))
    {
      Debug.DrawLine(ray.origin, hitInfo.point, Color.magenta);
    }
  }

  void Shot()
  {
    if (hitInfo.collider.tag == "objects")
    {
      Destroy(hitInfo.collider.gameObject);
    }
  }
}