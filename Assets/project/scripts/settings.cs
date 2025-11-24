using UnityEngine;
using UnityEditor.SceneManagement;
public class settings : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private Canvas main, Settings, audio, video;

    // Update is called once per frame
    public void change1()
    {
        main.gameObject.SetActive(false);
        Settings.gameObject.SetActive(true);
    }
    public void back1()
    {
        main.gameObject.SetActive(true);
        Settings.gameObject.SetActive(false);
    }
    public void chang2()
    {
        Settings.gameObject.SetActive(false);
        audio.gameObject.SetActive(true);
    }
    public void back2()
    {
        audio.gameObject.SetActive(false);
        Settings.gameObject.SetActive(true);
    }
    public void chang3()
    {
        Settings.gameObject.SetActive(false);
        video.gameObject.SetActive(true);
    }
    public void back3()
    {
        video.gameObject.SetActive(false);
        Settings.gameObject.SetActive(true);
    }
    
}

