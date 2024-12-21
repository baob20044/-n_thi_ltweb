//document.addEventListener('DOMContentLoaded', function () {
//    var initTabs = function () {
//        const tabs = document.querySelectorAll('[data-tab-target]');
//        const tabContents = document.querySelectorAll('[data-tab-content]');

//        tabs.forEach(tab => {
//            tab.addEventListener('click', () => {
//                // Find the target content
//                const target = document.querySelector(tab.dataset.tabTarget);

//                // Remove 'active' class from all content sections
//                tabContents.forEach(tabContent => {
//                    tabContent.classList.remove('active');
//                });

//                // Remove 'active' class from all tabs
//                tabs.forEach(tab => {
//                    tab.classList.remove('active');
//                });

//                // Add 'active' class to clicked tab and target content
//                tab.classList.add('active');
//                target.classList.add('active');
//            });
//        });
//    };

//    // Initialize tabs
//    initTabs();
//});
document.addEventListener('DOMContentLoaded', function () {
    var initTabs = function () {
        const tabs = document.querySelectorAll('[data-tab-target]')
        const tabContents = document.querySelectorAll('[data-tab-content]')

        tabs.forEach(tab => {
            tab.addEventListener('click', () => {
                const target = document.querySelector(tab.dataset.tabTarget)
                tabContents.forEach(tabContent => {
                    tabContent.classList.remove('active')
                })
                tabs.forEach(tab => {
                    tab.classList.remove('active')
                })
                tab.classList.add('active')
                target.classList.add('active')
            })
        });
    }
    initTabs();
});