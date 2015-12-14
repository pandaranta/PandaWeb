jQuery(document).ready(function () {
    jQuery(".pad").hide();
    jQuery(".heading").click(function () {
        jQuery(this).next(".pad").slideToggle(500);
        jQuery('#span1').html('&#8743;')
    });
});