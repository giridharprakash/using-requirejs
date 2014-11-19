"use strict";

define(["Backbone", "models/customer"],
function (backbone, Customer)
{
    var CustomerCollection = Backbone.Collection.extend(
    {
        model: Customer
    });

    return CustomerCollection;
});