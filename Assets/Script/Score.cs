using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;
    public int score_max;

    [SerializeField] private TextMeshProUGUI text_score;
    private Animator anim;

    public static Score Instance;

    private void Awake()
    {
        Instance = this;
        anim = GetComponent<Animator>();
        ajout_score(0);
    }

    public void ajout_score(int i)
    {
        score += i;
        if (score > score_max)
        {
            score = score_max;
        }
        text_score.text = "Score: " + score.ToString() + "/" + score_max;
        anim.SetTrigger("Pop");
    }
}
