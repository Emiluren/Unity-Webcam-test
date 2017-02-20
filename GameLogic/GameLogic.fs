namespace RollABall
open UnityEngine

type PlayerController() =
    inherit MonoBehaviour()

    [<SerializeField>]
    let mutable speed = 6.0f

    member this.FixedUpdate () =
        let moveHorizontal = Input.GetAxis("Horizontal")
        let moveVertical = Input.GetAxis("Vertical")

        //Debug.Log moveHorizontal

        let movement = Vector3(moveHorizontal, 0.0f, moveVertical)
        let rigidbody = this.GetComponent<UnityEngine.Rigidbody>()
        rigidbody.AddForce (movement * speed)

// type TextureViewer() =
//     inherit MonoBehaviour()

//     member this.Start() =
//         let webcamTexture = new WebCamTexture()
//         let mutable renderer = this.GetComponent<UnityEngine.Renderer>()
//         renderer.material.mainTexture <- webcamTexture
//         webcamTexture.Play()
