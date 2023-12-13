window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire(
            'Thành Công',
            message,
            "success"
        )
    }
    if (type === "error") {
        Swal.fire(
            'Lỗi!',
            message,
            'error'
        )
    }
}