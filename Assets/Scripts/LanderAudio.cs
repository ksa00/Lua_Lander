using UnityEngine;

public class LanderAudio : MonoBehaviour {


    [SerializeField] private AudioSource thrusterAudioSource;


    private Lander lander;


    private void Awake() {
        lander = GetComponent<Lander>();
    }

    private void Start() {
        lander.OnBeforeForce += Lander_OnBeforeForce;
        lander.OnUpForce += Lander_OnUpForce;
        lander.OnRightForce += Lander_OnRightForce;
        lander.OnLeftForce += Lander_OnLeftForce;

        SoundManager.Instance.OnSoundVolumeChanged += SoundManager_OnSoundVolumeChanged;

        thrusterAudioSource.Pause();
    }

    private void SoundManager_OnSoundVolumeChanged(object sender, System.EventArgs e) {
        thrusterAudioSource.volume = SoundManager.Instance.GetSoundVolumeNormalized();
    }

    private void Lander_OnLeftForce(object sender, System.EventArgs e) {
        if (!thrusterAudioSource.isPlaying) {
            thrusterAudioSource.Play();
        }
    }

    private void Lander_OnRightForce(object sender, System.EventArgs e) {
        if (!thrusterAudioSource.isPlaying) {
            thrusterAudioSource.Play();
        }
    }

    private void Lander_OnUpForce(object sender, System.EventArgs e) {
        if (!thrusterAudioSource.isPlaying) {
            thrusterAudioSource.Play();
        }
    }

    private void Lander_OnBeforeForce(object sender, System.EventArgs e) {
        thrusterAudioSource.Pause();
    }

}