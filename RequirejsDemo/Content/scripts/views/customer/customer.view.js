"use strict";

define(["jquery","Backbone","collections/customers"],
function ($, Backbone, Customers)
{
    var CustomerView = Backbone.View.extend(
    {
        render: function()
        {
            var customersData = this._populateCustomers();
            $(this.el).html(customersData);
            return this.el;
        },
        _populateCustomers: function()
        {
            var customers = new Customers([{ Name: "Customer1" }, { Name: "Customer2" }]);

            return JSON.stringify(customers.toJSON());
        },
        _getContainer: function()
        {
            return $(this.el);
        }
    });

    return CustomerView;
});