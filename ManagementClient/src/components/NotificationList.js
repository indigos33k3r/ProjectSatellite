import React from 'react';
import PropTypes from 'prop-types';

export class NotficationList extends React.Component {
  render() {
    return (
      <div>
        <h3>Notification List</h3>
        {this.props.View} 
      </div>
    );
  }
}

NotficationList.propTypes = {
  View: PropTypes.string.isRequired
};

export default NotficationList;
