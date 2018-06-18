
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {
    public Text Score;
    public Transform player;




    // Update is called once per frame
    void Update () {
        Score.text = player.position.z.ToString("0");

    }
}
