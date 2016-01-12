$(function () {
    $('.file-upload').on('change.bs.fileinput', function (event) {
        var fileName = $(this).find('.fileinput-filename').html();
        var hiddenName = $(this).find('input[type="hidden"][id$="Name"]');
        hiddenName.val(fileName);
    });
    $('.file-upload').on('clear.bs.fileinput', function (event) {
        var hiddenName = $(this).find('input[type="hidden"][id$="Name"]');
        hiddenName.val('');
        var hiddenContent = $(this).find('input[type="hidden"][id$="Content"]');
        hiddenContent.val('');
    });
    $('.file-upload').find('input[type="file"]').on('change', function (evt) {
        if (this.files && this.files[0]) {
            var hiddenContent = $(this).next();
            var reader = new FileReader();
            reader.onload = function (e) {
                var base64 = e.target.result;
                hiddenContent.val(base64);
            }
            reader.readAsDataURL(this.files[0]);
        }
    });
});