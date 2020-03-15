﻿class AdminController {
    constructor(options = null, target = null) {

        this.options = options;
        this.target = target;

        this._init();
    }

    _init() { }

    getBooksCountByUser() { this.__ajaxQuery("GET", "/api/ebs/bs1"); }
    getUserListAsc() { this.__ajaxQuery("GET", "/api/ebs/us1"); }

    __ajaxQuery(method, url) {
        $.ajax({
            method: method,
            url: url,
            beforeSend: function () {
                toastr.info("We process your request", "Please wait.");
            },
            success: function (result) {
                console.log(result);
                toastr.success("Request processed successfully", "Press F12");
            },
            error: function (xhr) {
                console.log(xhr);
                toastr.error("Failed to process request", "Error");
            }
        })
    }
}