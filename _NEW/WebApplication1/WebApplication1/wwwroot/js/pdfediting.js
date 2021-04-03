﻿$(document).ready(function () {
  $("#new-pdf-doc-button").click(function (e) {
    e.preventDefault();
    if (
      confirm(
        "Are you sure you want to make a new pdf file? Unsaved changes will be lost."
      )
    ) {
      // createANewPdf();
    }
  });

  $("#submit-pdf-button").click(function (e) {
    e.preventDefault();
    $.ajax({
      url: "",
      data: new FormData(document.forms[0]),
      contentType: false,
      processData: false,
      type: "post",
      success: function () {
        alert("Uploaded by jQuery");
      },
    });
  });

  $(".file-in-db").click(function (e) {
    e.preventDefault();
    $.ajax({
      url: $('.file-id').text() + "?handler=File",
      type: "get",
      success: function (data) {
          alert(data)
      },
      error: function () {
          alert('Could not find a file.')
      },
    });
  });
});
