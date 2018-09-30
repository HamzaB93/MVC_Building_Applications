
$(function () {
    
    
    var ajaxFormSubmit = function () {
        //grab reference to the from and wwrap jquery around it 
        var $form = $(this);

        //create options object
        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        //Make asynch call
        // Use ajax, more flexible, when done call the function and save result in data
        $.ajax(options).done(function (data) {

            // what dom element to update with the data
            var $target = $($form.attr("data-otf-target"));
            
            //replace the target with the html we got back
            $target.replaceWith(data);

            // Prevent browser from completed default action
            return false;
        });
    };

    // Use jquery to find a data attribute based on name and what they are set to
    // Then wire it to an event and call our own function
    $("form[data-otf-ajax='true']").submit(ajaxFormSubmit);
});