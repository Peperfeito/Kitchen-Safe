using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInventory : MonoBehaviour
{
    // make a flipflop button to open and close the inventory when clicked
    public GameObject inventory;

    public void OpenCloseInventory()
    {
        inventory.SetActive(!inventory.activeSelf);
    }

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }
}
