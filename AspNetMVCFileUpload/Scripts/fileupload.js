$(function () {
    $('.file-upload, .image-upload').on('change.bs.fileinput', function (event) {
        var fileName = $(this).find('.fileinput-filename').html();
        var hiddenName = $(this).find('input[type="hidden"][id$="Name"]');
        hiddenName.val(fileName);
    });
    $('.file-upload, .image-upload').on('clear.bs.fileinput', function (event) {
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
    $('.image-upload').find('input[type="file"]').on('change', function (evt) {
        if (this.files && this.files[0]) {
            var hiddenContent = $(this).next();
            var hiddenWidth = $(hiddenContent).next();
            var hiddenHeight = $(hiddenWidth).next();
            var width = $(hiddenWidth).val();
            var height = $(hiddenHeight).val();

            var reader = new FileReader();
            reader.onload = function (e) {
                var base64 = e.target.result;

                var canvas = document.createElement("canvas");
                canvas.width = width;
                canvas.height = height;
                var context = canvas.getContext("2d");
                $("<img/>").attr("src", base64).load(function () {
                    context.scale(width / this.width, height / this.height);
                    context.drawImage(this, 0, 0);
                    hiddenContent.val(canvas.toDataURL());
                });
            }
            reader.readAsDataURL(this.files[0]);
        }
    });
});