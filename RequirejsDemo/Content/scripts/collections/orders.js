"use strict";

define(["Backbone", "models/order"],
function (backbone, Order)
{
    var OrderCollection = Backbone.Collection.extend(
    {
        model: Order
    });

    return OrderCollection;
});