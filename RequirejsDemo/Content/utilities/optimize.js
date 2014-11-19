
({
    appDir:"../scripts/",
    baseUrl: ".", // this relative to appDir or build.js
    preserveLicenseComments: false,
    dir: "../minifiedscripts/",
    modules: [
    {
        name: "views/customer/customer.view"
    }],
    paths: {        //this is relative to base url
        "jquery": "empty:",
        "Backbone": "empty:"
    }
})
