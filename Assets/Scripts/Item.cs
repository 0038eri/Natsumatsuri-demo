using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

  private int steps = 0;

  private GameObject itemManager;
  private ItemManager item_manager;

  void Start()
  {
    itemManager = GameObject.Find("GameObject");
    item_manager = itemManager.GetComponent<ItemManager>();
  }

  void Update()
  {
    if (steps == 2)
    {
      transform.position = itemManager.transform.position;
      transform.rotation = itemManager.transform.rotation;
    }

  }

  void OnCollisionEnter(Collision col)
  {
    if (col.gameObject.tag == "field")
    {
      Destroy(this.gameObject);
    }
  }

  public void receiveSteps()
  {
    steps = item_manager.sendSteps();
  }

}