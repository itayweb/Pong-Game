using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // [SerializeField] private GameObject ui;
    [SerializeField] private Text player1Text;    
    [SerializeField] private Text player2Text;
    private static Score instance;
    private static GameObject ui;
    private int player1Counter = 0;
    private int player2Counter = 0;    

    private void Awake() {
        CheckDuplicate();
    }

    // Start is called before the first frame update
    void Start()
    {
        player1Text.text = player1Counter.ToString();
        player2Text.text = player2Counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore(string direction) {
        if (direction == "Left") {
            player1Counter++;
            player1Text.text = player1Counter.ToString();
        }
        else if (direction == "Right") {
            player2Counter++;
            player2Text.text = player2Counter.ToString();
        }
    }

    void CheckDuplicate() {
        ui = GameObject.Find("UI");
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        }
        else {
            instance = this;
            DontDestroyOnLoad(ui);
        }
    }
}
