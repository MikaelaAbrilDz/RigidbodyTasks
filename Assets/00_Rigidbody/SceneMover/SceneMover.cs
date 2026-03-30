using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneMover : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI sceneNum;
    private void Start()
    {
        sceneNum.text = "" + (SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
