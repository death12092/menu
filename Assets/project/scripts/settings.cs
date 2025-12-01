using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.Audio;
using Unity.VisualScripting;
public class settings : MonoBehaviour
{
    
    [SerializeField]
    private Canvas main, Settings, audio, video;
    [SerializeField]
    private AudioMixer mixer;
    [SerializeField]


    // change screens
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
    public void changevideo(int settingLevel)
    {
        QualitySettings.SetQualityLevel(settingLevel);
    }
    public void changerender(float scale)
    {
        UniversalRenderPipelineAsset pipeline = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
        pipeline.renderScale = scale;
    }
    public void Audio(float volume)
    {
        mixer.SetFloat("music", volume);
        PlayerPrefs.SetFloat("music", volume);
        PlayerPrefs.Save();
    }
    public void buttonaudio(float booton)
    {
        mixer.SetFloat("vfx", booton);
        PlayerPrefs.SetFloat("vfx", booton);
        PlayerPrefs.Save();
    }
    public void masteraudio(float master)
    {
        mixer.SetFloat("master", master);
        PlayerPrefs.SetFloat("master", master);
        PlayerPrefs.Save();
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            mixer.SetFloat("music", PlayerPrefs.GetFloat("music"));
        }
        if (PlayerPrefs.HasKey("vfx"))
        {
            mixer.SetFloat("vfx", PlayerPrefs.GetFloat("vfx"));
        }
        if (PlayerPrefs.HasKey("master"))
        {
            mixer.SetFloat("master", PlayerPrefs.GetFloat("master"));
        }
    }

}

