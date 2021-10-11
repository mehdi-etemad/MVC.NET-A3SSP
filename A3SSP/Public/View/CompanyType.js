function CompanyTypeDelete(Id) {
    ModalBox('Delete Confirm', 'Are you sure to delete this company type?', '<a class="btn btn-danger" href="/CompanyTypeDelete/' + Id + '">Delete</a>');
}