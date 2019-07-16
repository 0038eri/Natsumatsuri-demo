using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yoyoManager : MonoBehaviour
{

  private int point = 0;
  [SerializeField] private int add;
  public Text text;

  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      transform.position += new Vector3(0.0f, 0.0f, 0.5f);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.position += new Vector3(0.5f, 0.0f, 0.0f);
    }
    else if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position += new Vector3(-0.5f, 0.0f, 0.0f);
    }
    else if (Input.GetKey(KeyCode.DownArrow))
    {
      transform.position += new Vector3(0.0f, 0.0f, -0.5f);
    }

    text.text = "point: " + point.ToString();
  }

  void OnTriggerStay(Collider col)
  {
    if (col.gameObject.tag == "yoyo")
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        point += add;
        Destroy(col.gameObject);
      }
    }
  }

}