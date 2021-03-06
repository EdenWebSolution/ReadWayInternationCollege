$(document).ready(function () {
    "use strict";

    //---- back to page top button --
    $('.totop').tottTop();
    

    //Mean Menu
    jQuery('header .main-menu').meanmenu({
        meanScreenWidth: "767"
    });

    //Sticky Nav
    $(".edu-navbar").sticky({ topSpacing: 0 });

    //Scroll Spy		
    $('body').scrollspy({ target: '.edu-navbar' });
    $(window).on('load', function (e) {
        $('#status').fadeOut();
        $('#preloader').delay(350).fadeOut('slow');
        $('body').delay(350).css({ 'overflow': 'visible' });
    })
    $('body').scrollspy({ target: ".edu-navbar'" })

    //Video Popup	
    $('.video-iframe').magnificPopup({
        type: 'iframe',
        iframe: {
            markup: '<div class="mfp-iframe-scaler">' +
            '<div class="mfp-close"></div>' +
            '<iframe class="mfp-iframe" frameborder="0" allowfullscreen></iframe>' +
            '</div>',
            patterns: {
                youtube: {
                    index: 'youtube.com/',
                    id: 'v=',
                    src: 'http://www.youtube.com/embed/%id%?autoplay=1'
                }
            },
            srcAction: 'iframe_src'
        }
    });

    //Popup
    $('.gallery-single-item').magnificPopup({
        delegate: 'li .port-view',
        type: 'image',
        gallery: {
            enabled: true
        },
        removalDelay: 300,
        mainClass: 'mfp-fade'
    });

    //jQuery Counter	
    $('.counter').counterUp({
        delay: 10,
        time: 1000
    });

    // ************ Search On Click
    $(".search_btn").on("click", function (event) {
        event.preventDefault();
        $("#search").addClass("open");
        $("#search > form > input[type='search']").focus();
    });

    $("#search, #search button.close").on("click keyup", function (event) {
        if (event.target == this || event.target.className == "close" || event.keyCode == 27) {
            $(this).removeClass("open");
        }
    });

    // Slick slider	index version

    $('.slider-for').slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        arrows: false,
        fade: true,
        asNavFor: '.slider-nav'
    });
    $('.slider-nav').slick({
        slidesToShow: 3,
        slidesToScroll: 1,
        asNavFor: '.slider-for',
        dots: false,
        height: true,
        centerMode: true,
        centerPadding: '0px',
        focusOnSelect: true,
        variableWidth: false,
        arrows: true

    });

    // Parent Say's index-02 
    $("#parent-say-02").owlCarousel({
        items: 3,
        lazyLoad: true,
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: true,
        pagination: false,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            480: {
                items: 1,
                nav: false
            },
            768: {
                items: 2,
                nav: true
            },
            992: {
                items: 2,
                nav: true,
                loop: false
            }
        }
    });


    // Courses-carousel index-03 	
    $("#courses-carousel-03").owlCarousel({
        items: 4,
        lazyLoad: true,
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: true,
        pagination: false,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            480: {
                items: 1,
                nav: false
            },
            768: {
                items: 2,
                nav: true
            },
            992: {
                items: 3,
                nav: true,
                loop: false
            }
        }
    });

    // Courses-carousel index-04 	
    $("#courses-carousel-04").owlCarousel({
        items: 1,
        lazyLoad: true,
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: true,
        pagination: false,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            480: {
                items: 1,
                nav: false
            },
            768: {
                items: 2,
                nav: true
            },
            992: {
                items: 3,
                nav: true,
                loop: false
            }
        }
    });

    // Blog-carousel index-03 
    $("#bolg-carousel-03").owlCarousel({
        items: 3,
        lazyLoad: true,
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: true,
        pagination: false,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            480: {
                items: 1,
                nav: false
            },
            768: {
                items: 2,
                nav: true
            },
            992: {
                items: 3,
                nav: true,
                loop: false
            }
        }
    });

    // Partners carousel index-03 
    $("#partners-carousel-03").owlCarousel({
        items: 6,
        lazyLoad: true,
        navigation: false,
        navigationText: ["", ""],
        pagination: false,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            480: {
                items: 2,
                nav: false
            },
            768: {
                items: 3,
                nav: true
            },
            992: {
                items: 4,
                nav: true,
                loop: false
            }
        },
        afterAction: function (el) {
            //remove class active
            this
                .$owlItems
                .removeClass('active')

            //add class active
            this
                .$owlItems //owl internal $ object containing items
                .eq(this.currentItem + 3)
                .addClass('active')
        }
    });
    // Success carousel index-04 	
    $("#success-carousel-04").owlCarousel({
        items: 1,
        lazyLoad: true,
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: false,
        pagination: true,
        responsive: false
    });
    // Bolg carousel index-04 	
    $("#bolg-carousel-01").owlCarousel({
        items: 1,
        lazyLoad: true,
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: true,
        pagination: false,
        responsive: false
    });

    $("#single-carousel-03").owlCarousel({
        items: 4,
        lazyLoad: true,
        navigationText: ["<i class='fa fa-angle-left'></i>", "<i class='fa fa-angle-right'></i>"],
        slideSpeed: 500,
        paginationSpeed: 1000,
        rewindSpeed: 1000,
        navigation: true,
        pagination: false,
        responsive: {
            0: {
                items: 1,
                nav: false
            },
            480: {
                items: 1,
                nav: false
            },
            768: {
                items: 2,
                nav: true
            },
            992: {
                items: 3,
                nav: true,
                loop: false
            }
        }
    });


    $("#SendMoreInfoForm").submit(function (event) {
        event.preventDefault();
        event.stopImmediatePropagation();
        var action = $("#SendMoreInfoForm").attr("action");
        var Email = $('#getInfoEmail').val();
        if (Email == null || Email == '') {

            toastr.error("Please enter your email address", "Failed");
            return;
        }
        if (!isEmail(Email)) {

            toastr.error("Invalid email address", "Failed");
            return;
        }
        $('#getIntouchloader').show();
        $('#getIntouchID').hide();
        var dataString;
        var action = $("#SendMoreInfoForm").attr("action");
        dataString = new FormData($("#SendMoreInfoForm").get(0));


        var formID = $(this).closest("form").attr('id');

        var token = $('input[name="__RequestVerificationToken"]').val();
        $.ajaxPrefilter(function (options, originalOptions) {
            if (options.type.toUpperCase() == "POST" && formID == 'SendMoreInfoForm') {
                options.data = $.param($.extend(originalOptions.data, { __RequestVerificationToken: token }));
                formID = null;
            }
        });

        $.ajax({
            type: 'post',
            dataType: 'json',
            url: action,

            data: { "emailAddress": Email.toString() },
            success: function (result) {

                onFooterAjaxRequestSuccess(result);
            },
            error: function (jqXHR, textStatus, errorThrown) {

                toastr.error("Something went wrong, please try refreshing the page", "Failed");
                $('#getIntouchloader').hide();
                $('#getIntouchID').show();
            }
        });

    });
});

var onFooterAjaxRequestSuccess = function (result) {
    var status = result.status;
    if (status == 0) {
        toastr.success(result.message, result.subject);
        $('#getInfoEmail').val('');
        $('#getIntouchloader').hide();
        $('#getIntouchID').show();
    }

    else if (status == 1) {
        toastr.error(result.message, result.subject);
        $('#getIntouchloader').hide();
        $('#getIntouchID').show();
    }
}

function isEmail(email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}
