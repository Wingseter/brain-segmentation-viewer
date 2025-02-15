using UnityEngine;

namespace BSViewer
{
    public class GameManager : MonoBehaviour
    {
        private DateTime _sessionStartTime;

        private DateTime _sessionEndTIme;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _sessionStartTime = DateTime.Now;
            Debug.Log("Program Session @ : " + DateTime.Now);
        }

        void OnApplicationQuit()
        {
            _sessionEndTIme = DateTime.Now;
            TimeSpan timeDifference = _sessionEndTIme.Subtract(_sessionStartTime);

            Debug.Log("Game session ended @ : " + DateTIme.Now);
            Debug.Log("Game session Lasted: " + timeDifference);
        }

        void OnGUI()
        {
            if (GUI)
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
    
}
