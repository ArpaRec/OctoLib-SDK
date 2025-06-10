namespace OctoLib.SDK
{
    public class TimedQuest : MonoBehaviour
    {
        public float TimeLimit = 60f;
        public AudioClip BeginSFX;
        public AudioClip TimerTick;
        public AudioClip SuccessSFX;
        public AudioClip FailureSFX;
        public AudioClip CollectSFX;
        public List<GameObject> Collectables;
        public AudioSource AudioSource;

        private bool _isCountingDown;
        private float _timeRemaining;
        private int _collectableCountRemaining;
        private object _countdownCoroutine;
        private object _tickCoroutine;

        private void Start()
        {

        }

        private void CollectCollectable(Collider cObject, GameObject triggeringCollectable)
        {

        }

        public void StartTimeTrial()
        {

        }

        private void OnTimerFinished()
        {

        }

        private IEnumerator CountdownLoop()
        {
	    yield return default;
        }

        private IEnumerator TickSound()
        {
	    yield return default;
        }
    }
}
