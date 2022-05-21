using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public static MainController main;

    private void Awake()
    {
        if (main == null)
        {
            main = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
    }

    public GameObject MentionBoard;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.R) && (Input.GetKey(KeyCode.LeftControl) || (Input.GetKey(KeyCode.RightControl))))
        {
            MentionBoard.SetActive(true);
        }
    }
}