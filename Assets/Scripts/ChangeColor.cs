using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

  [SerializeField] private Camera camera_;
  [SerializeField] private float distance;

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Shot();
    }
  }

  void Shot()
  {
    Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    Ray ray = camera_.ScreenPointToRay(center);
    RaycastHit hitInfo;

    if (Physics.Raycast(ray, out hitInfo, distance))
    {
      if (hitInfo.collider.tag == "objects")
      {
        Destroy(hitInfo.collider.gameObject);
      }
    }
  }

}