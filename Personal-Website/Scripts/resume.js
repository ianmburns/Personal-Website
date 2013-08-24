$(document).ready(function() {
    var headerOffset = 10;

    $('#resume-nav li a').on('click', function(e) {
        e.preventDefault();
        var element = $(this.hash);
        var offset = $('#topNav').height() + headerOffset;
        $(document.body).scrollTo(element, 800, { offset: { top: -offset, left: 0 } });
    });

    var scrollSpacerHeight = function() {
        return ($(window).height() - $("#Education").height()) - $('#topNav').height() - $('#footer').height() - headerOffset;
    };

    $('#scrollSpacer').height(scrollSpacerHeight);

    $(window).on('resize', function() {
        $('#scrollSpacer').height(scrollSpacerHeight);

        $('[data-spy="scroll"]').each(function() {
            $(this).scrollspy('refresh');
        });
    });

    var navHeight = $('#topNav').outerHeight(true) + headerOffset;
    $('body').scrollspy({ target: '#resume-nav', offset: navHeight });
});