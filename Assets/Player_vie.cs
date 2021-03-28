using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_vie : MonoBehaviour
{
    [SerializeField] private int vie_max;
    private int vie;
    [Space]
    [SerializeField] private Slider slider;

    public static Player_vie Instance;

    private void Awake()
    {
        Instance = this;
        vie = vie_max;
        slider.maxValue = vie_max;
    }

    public void Degat(int i)
    {
        vie -= i;
        slider.value = vie;
        if(vie <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
