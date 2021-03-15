﻿$(document).ready(function () {
    let mediaRecorder;
    let audioChunks;

    //Video Functionality/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    $("#video-button").click(function (e) {
        $('.main').empty();
        $('.main').append(`<h1 id="youtube-title"><i class="fab fa-youtube"></i>Youtube Playback Function </h1>
            <input type="text" name="youtube-input" id="youtube-search-bar" placeholder="Enter a youtube embedded url">
            <button id="youtube-search-button">Go!</button>
            <div class="video-container">
                <iframe id="#youtube-video"width="860" height="615" src="https://www.youtube.com/embed/Oa9QeMHNOm4" frameborder="0" allow="accelerometer;
                    autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            </div>`);
    });

    $(".main").on('click', '#youtube-search-button', function (e) {
        e.preventDefault();
        let source = $('#youtube-search-bar').val()
        let x = $('#youtube-video').attr('src')
        console.log(x)

    })

    //Audio Functionality/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    $('#audio-button').click(function (e) {
        e.preventDefault();
        $('.main').empty();

        let audioControlsDiv = $(`<div></div>`)
        let startButton = `<button id="start-recording-button"><i id='start-recording-icon' class="fas fa-circle"></i><h4>Start Recording</h4></button>`
        let stopButton = `<button id="stop-recording-button"><i id='stop-recording-icon' class="fas fa-square"></i><h4>Stop Recording</h4></button>`
        let openRecordingButton = `<button id="open-recording-button"><i id='open-recording-icon' class="fas fa-file-audio"></i><h4>Open a Recording</h4></button>`
        let mainAudioControl = `<audio id="recording-controller" controls><source src="#" type="audio/mp3">Audio not supported</audio>`
        let recordingStatusText = `<h1 id="recording-status-text">Press "Start Recording" To Begin.</h1>`

        $(audioControlsDiv).append(startButton, stopButton, openRecordingButton);
        $(audioControlsDiv).addClass('recording-buttons-container');
        $('.main').append(audioControlsDiv, recordingStatusText, mainAudioControl);
    });

    //The click handler has to be binded this way since it does not exist until the audio button is selected from the media tab.
    $('.main').on("click", "#start-recording-button", function (e) {
        e.preventDefault()
        $('#recording-status-text').text("Recording In Progress...");

        navigator.mediaDevices.getUserMedia({ audio: true })
            .then(stream => {
                mediaRecorder = new MediaRecorder(stream);
                mediaRecorder.start();

                audioChunks = [];

                mediaRecorder.addEventListener("dataavailable", event => {
                    audioChunks.push(event.data);
                });

                mediaRecorder.addEventListener("stop", () => {
                    const audioBlob = new Blob(audioChunks);
                    const blobToSave = convertBlobToMp4(audioBlob, "Blobbie")
                    const audioUrl = URL.createObjectURL(audioBlob);

                    let audio = document.querySelector('audio');
                    audio.src = audioUrl

                    console.log(blobToSave)
                });
            })
    })

    $('.main').on("click", "#stop-recording-button", function (e) {
        e.preventDefault();
        mediaRecorder.stop();
        $('#recording-status-text').text("Recording Completed.")

    })

    $('.main').on("click", "#open-recording-button", function (e) {
        e.preventDefault();
        // Get the modal
        var modal = document.getElementById("myModal");

        // Get the button that opens the modal (I removed this line since it's no longer being used -David)
        //var btn = document.getElementById("open-recording-button");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName("close")[0];

        // When the user clicks on the button, open the modal
        modal.style.display = "block";

        // When the user clicks on the button, open the modal
        /*
        I moved this outside of the function definition here - if left inside requires 2 clicks to open modal
        this.onclick = function () {//Changed btn to this since this refers to #open-recording-button in current scope
            modal.style.display = "block";
        }
        */
        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = "none";
        }

        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = "none";
            }
        }
    })

    //PDF Functionality/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    $('#file-button').click(function (e) {
        e.preventDefault();
        $('.main').empty();
        $('.main').append(`<iframe src="https://pdf-lib.js.org/assets/with_update_sections.pdf"
            frameborder="1" width="100%" height="100%"></iframe>`);
    });

    //ETC////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    $('#upload-button').click(function (e) {
        let $element = `<button id="modal-btn"> click me, I make a modal</button>
            <div class="modal">
                <div class="modal-content">
                    <span class="close-btn">&times;</span>
                    <p>this is the text inside the modal</p>
                </div>
            </div>`
        $('body').append($element).show();
    })
});
    //For the modal//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    

//Helper functions///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function convertBlobToMp4(blob, fileName) {
    blob.lastModifiedDate = new Date();
    blob.name = fileName;
    blob.type = "audio/mp3";

    return blob;
}