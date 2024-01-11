using CodeBase.Infrastructure.EntyPoint;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBootstrapper
    {
        public override void Bootstrap()
        {
            Debug.Log("GLOBAL: Init");

            DontDestroyOnLoad(gameObject);

            Application.targetFrameRate = Screen.currentResolution.refreshRate;

            //TODO
            SceneManager.LoadScene("Level_1");
        }
    }
}