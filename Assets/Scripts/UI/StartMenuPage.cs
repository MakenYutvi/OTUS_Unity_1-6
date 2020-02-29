using UnityEngine;
using UnityEngine.UI;

public class StartMenuPage : MonoBehaviour
{
    public string BattleSceneName1;
    public string BattleSceneName2;
    public Button PlayButtonLevel1;
    public Button PlayButtonLevel2;
    public LoadingLogicPage LoadingLogic;

    private void Awake()
    {
        PlayButtonLevel1.onClick.AddListener(PlayGameLevel1);
        PlayButtonLevel2.onClick.AddListener(PlayGameLevel2);
    }

    private void PlayGameLevel1()
    {
        Time.timeScale = 1;
        LoadingLogic.LoadScene(BattleSceneName1);
    }

    private void PlayGameLevel2()
    {
        Time.timeScale = 1;
        LoadingLogic.LoadScene(BattleSceneName2);
    }
}
