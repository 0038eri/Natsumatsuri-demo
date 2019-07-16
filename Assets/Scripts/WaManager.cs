using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaManager : MonoBehaviour
{
  public GameObject item_prefab;

  private GameObject wa;
  private Wa _item;

  private int steps = 0;
  private bool itemFlag = false;
  private bool triggerFlag = false;

  void Start()
  {

  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      if (triggerFlag == false)
      {
        steps++;
      }
      triggerFlag = true;
    }

    if (steps == 1)
    {
      if (itemFlag == false)
      {
        wa = Instantiate(item_prefab, transform.position, transform.rotation);
        _item = wa.GetComponent<Wa>();
        itemFlag = true;
      }
    }
    else if (steps == 2)
    {
      if (triggerFlag == true)
      {
        if (Input.GetKeyUp(KeyCode.Space))
        {
          steps++;
          _item.receiveSteps();
        }
      }
    }
    else if (steps == 3)
    {
      // 投げる
    }
    else if (steps == 4)
    {
      // 待機
    }
    else if (steps == 5)
    {
      itemFlag = false;
      triggerFlag = false;
    }

    Debug.Log(steps);
  }

  void LateUpdate()
  {
    if (steps == 1)
    {
      steps = 2;
      _item.receiveSteps();
    }
    else if (steps == 3)
    {
      steps = 4;
      _item.receiveSteps();
    }
    else if (steps == 4)
    {
      if (wa == null)
      {
        steps = 5;
      }
    }
    else if (steps == 5)
    {
      steps = 0;
    }
  }

  public int sendSteps()
  {
    return steps;
  }

}