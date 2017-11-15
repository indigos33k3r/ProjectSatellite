import React from 'react';
import PropTypes from 'prop-types';

export class IncidentList extends React.Component {
  render() {
    return (
      <div>
        <h3>Incident List</h3>
        {this.props.View}
      </div>
    );
  }
}

IncidentList.propTypes = {
  View: PropTypes.string.isRequired
};

export default IncidentList;
